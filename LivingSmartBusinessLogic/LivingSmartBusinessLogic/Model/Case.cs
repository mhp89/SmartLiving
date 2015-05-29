using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using LivingSmartBusinessLogic.Controller;

namespace LivingSmartBusinessLogic
{
    public class Case
    {
        #region Private Fields

        private int _sellerId;
        private int _buyerId;
        private int _estateAgentId;
        private DateTime _creationDate;
        private string _status;
        private DateTime _dateOfSale;
        private DateTime _transferDate;
        private DateTime _dateOfCompletion;
        private long? _sellingPrice;
        private string _description;
        private string _landRegistryNumber;
        private string _address;
        private int _zipCode;
        private int _propertyTypeId;
        private long _publicRating;
        private long _landValue;
        private int _groundArea;
        private int _builtArea;
        private int _livingArea;
        private int _basementArea;
        private int _builtYear;
        private string _energyClassification;
        private int _floors;
        private int _rooms;
        private int _bedrooms;
        private int _bathrooms;
        private int _toilets;
        private int _garageArea;
        private int _view;
        private string _neighborhood;

        #endregion

        #region Properties

        public int Id { get; private set; }
        public int SellerId { get { return _sellerId; } internal set { _sellerId = value; } }
        public int BuyerId { get { return _buyerId; } internal set { _buyerId = value; } }
        public int EstateAgentId { get { return _estateAgentId; } internal set { _estateAgentId = value; } }
        public DateTime CreationDate { get { return _creationDate; } internal set { _creationDate = value; } }
        public string Status { get { return _status; } internal set { _status = value; } }
        public DateTime DateOfSale { get { return _dateOfSale; } internal set { _dateOfSale = value; } }
        public DateTime TransferDate { get { return _transferDate; } internal set { _transferDate = value; } }
        public DateTime DateOfCompletion { get { return _dateOfCompletion; } internal set { _dateOfCompletion = value; } }
        public long? SellingPrice { get { return _sellingPrice; } internal set { _sellingPrice = value; } }
        public string Description { get { return _description; } internal set { _description = value; } }
        public string LandRegistryNumber { get { return _landRegistryNumber; } internal set { _landRegistryNumber = value; } }
        public string Address { get { return _address; } internal set { _address = value; } }
        public int ZipCode { get { return _zipCode; } internal set { _zipCode = value; } }
        public int PropertyTypeId { get { return _propertyTypeId; } internal set { _propertyTypeId = value; } }
        public long PublicRating { get { return _publicRating; } internal set { _publicRating = value; } }
        public long LandValue { get { return _landValue; } internal set { _landValue = value; } }
        public int GroundArea { get { return _groundArea; } internal set { _groundArea = value; } }
        public int BuiltArea { get { return _builtArea; } internal set { _builtArea = value; } }
        public int LivingArea { get { return _livingArea; } internal set { _livingArea = value; } }
        public int BasementArea { get { return _basementArea; } internal set { _basementArea = value; } }
        public int BuiltYear { get { return _builtYear; } internal set { _builtYear = value; } }
        public string EnergyClassification { get { return _energyClassification; } internal set { _energyClassification = value; } }
        public int Floors { get { return _floors; } internal set { _floors = value; } }
        public int Rooms { get { return _rooms; } internal set { _rooms = value; } }
        public int Bedrooms { get { return _bedrooms; } internal set { _bedrooms = value; } }
        public int Bathrooms { get { return _bathrooms; } internal set { _bathrooms = value; } }
        public int Toilets { get { return _toilets; } internal set { _toilets = value; } }
        public int GarageArea { get { return _garageArea; } internal set { _garageArea = value; } }
        public int View { get { return _view; } internal set { _view = value; } }
        public string Neighborhood { get { return _neighborhood; } internal set { _neighborhood = value; } }

        #endregion

        internal Case()
        {
            CreationDate = new DateTime().Date;
        }
        internal Case(int sellerId, int buyerId, int estateAgentId, 
            DateTime creationDate, string status, DateTime dateOfSale, 
            DateTime transferDate, DateTime dateOfCompletion, long sellingPrice, 
            string description, string landRegistryNumber, string address, int zipCode, 
            int propertyTypeId, long publicRating, long landValue, 
            int groundArea, int builtArea, int livingArea, int basementArea, 
            int builtYear, string energyClassification, int floors, int rooms, 
            int bedrooms, int bathrooms, int toilets, int garageArea, 
            int view, string neighborhood)
        {
            SellerId = sellerId;
            BuyerId = buyerId;
            EstateAgentId = estateAgentId;
            CreationDate = creationDate;
            Status = status;
            DateOfSale = dateOfSale;
            TransferDate = transferDate;
            DateOfCompletion = dateOfCompletion;
            SellingPrice = sellingPrice;
            Description = description;
            LandRegistryNumber = landRegistryNumber;
            Address = address;
            ZipCode = zipCode;
            PropertyTypeId = propertyTypeId;
            PublicRating = publicRating;
            LandValue = landValue;
            GroundArea = groundArea;
            BuiltArea = builtArea;
            LivingArea = livingArea;
            BasementArea = basementArea;
            BuiltYear = builtYear;
            EnergyClassification = energyClassification;
            Floors = floors;
            Rooms = rooms;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            Toilets = toilets;
            GarageArea = garageArea;
            View = view;
            Neighborhood = neighborhood;
        }

	    #region Methods

        internal void CloseCase()
        {
            throw new System.NotImplementedException();
        }
        
        #endregion
    }
}
