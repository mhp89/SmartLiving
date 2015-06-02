using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;

namespace LivingSmartForms.Views
{
    public partial class NewCustomer : UserControl
    {
        private Customer currentCustomer;

        public NewCustomer(BaseForm baseForm, Customer customer)
        {
            InitializeComponent();

            currentCustomer = customer;

            if (currentCustomer != null)
            {
                stbCustomerName.Text = customer.Name;
                stbCustomerAddress.Text = customer.Address;
                stbCustomerZipCode.Text = customer.City.ZipCode.ToString();
                stbCustomerEmail.Text = customer.Email;
                stbCustomerPhone.Text = customer.Telephone;
                dafCustomerBirthday.SetDate(customer.DateOfBirth);
            }
        }

        public bool Save()
        {
            bool fielddataOk = ValidateFields();
            if (fielddataOk)
            {
                if (currentCustomer == null)
                {
                    {
                        CustomerController.Instance.MakeNewCustomer(stbCustomerName.Text,
                            (DateTime) dafCustomerBirthday.GetDateTime(),
                            stbCustomerAddress.Text,
                            Convert.ToInt32(stbCustomerZipCode.Text),
                            stbCustomerEmail.Text,
                            stbCustomerPhone.Text);
                        CustomerController.Instance.SaveActiveCustomer();
                    }
                }
                else
                {
                    CustomerController.Instance.SetActiveCustomer(currentCustomer);
                    CustomerController.Instance.SetName(stbCustomerName.Text);
                    CustomerController.Instance.SetAddress(stbCustomerAddress.Text);
                    CustomerController.Instance.SetCity(Convert.ToInt32(stbCustomerZipCode.Text));
                    CustomerController.Instance.SetEmail(stbCustomerEmail.Text);
                    CustomerController.Instance.SetTelephone(stbCustomerPhone.Text);
                    CustomerController.Instance.SetDateOfBirth((DateTime)dafCustomerBirthday.GetDateTime());
                    CustomerController.Instance.SaveActiveCustomer();
                }
            }
            return fielddataOk;
        }

        private bool ValidateFields()
        {
            bool fielddataOk = true;

            fielddataOk &= stbCustomerName.Validate();
            fielddataOk &= stbCustomerAddress.Validate();
            fielddataOk &= stbCustomerZipCode.Validate();
            fielddataOk &= stbCustomerPhone.Validate();
            fielddataOk &= stbCustomerEmail.Validate();
            fielddataOk &= dafCustomerBirthday.Validate();

            return fielddataOk;
        }

        private void stbCustomerZipCode_TextChanged(object sender, EventArgs e)
        {
            City city = null;

            if (stbCustomerZipCode.Validate())
            {
                int zipCode = Convert.ToInt32(stbCustomerZipCode.Text);
                city = CityController.Instance.GetCity(zipCode);

                if (city == null)
                    stbCustomerZipCode.SetError("Ugyldigt postnummer");
            }

            lblCustomerCityCountry.Text = city != null ? city.District : "";
        }
    }
}
