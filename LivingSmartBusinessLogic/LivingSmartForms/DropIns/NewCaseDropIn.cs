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
using LivingSmartForms.Pages;
using LivingSmartForms.Views;
using SmartControls;

namespace LivingSmartForms.DropIns
{
	public partial class NewCaseDropIn : BaseDropIn
	{
		private CaseStep[] steps;
		private CaseStep activeStep;
		private int currentStepIndex;

		enum StepsIndex
		{
			Seller,
			Lot,
			Property,
			Details
		}


		public NewCaseDropIn(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();

			CaseController.Instance.MakeNewCase();

			steps = new CaseStep[Enum.GetNames(typeof(StepsIndex)).Length];

			steps[(int)StepsIndex.Seller] = new NewCaseStepSeller(baseForm);
            steps[(int)StepsIndex.Lot] = new NewCaseStepLot(baseForm);
			steps[(int)StepsIndex.Property] = new NewCaseStepProperty(baseForm);
			steps[(int)StepsIndex.Details] = new NewCaseStepDetails(baseForm);

			InitializeSteps();

			ChangeStep((int)StepsIndex.Seller);
		}
		public override string GetDropInId()
		{
			return "NewCase";
		}

		private void InitializeSteps()
		{
			stepIndicator.Steps = steps.Length;
			
			foreach (var step in steps)
			{
				step.Dock = DockStyle.Top;
				
				if (step.MinimumSize == Size.Empty)
					step.MinimumSize = new Size(0, step.Size.Height);
			}
		}

		private void ChangeStep(int stepIndex)
		{
			activeStep = steps[stepIndex];
			pnlStepHolderInner.Controls.Clear();
			pnlStepHolderInner.Controls.Add(activeStep);
			activeStep.Height = pnlStepHolderInner.Height;
			
			currentStepIndex = stepIndex;
			stepIndicator.CurrentStep = stepIndex;

			UpdateButtons();
		}

		private void NextStep()
		{
			if (activeStep.Save())
			{
				if (currentStepIndex == steps.Length - 1)
				{
					//Finish
					CaseController.Instance.SaveActiveCase();

					Close();
				}
				else
				{
					ChangeStep(currentStepIndex + 1);
				}
			}
		}

		private void PrevStep()
		{
			if(currentStepIndex == 0)
				return;

			ChangeStep(currentStepIndex-1);
		}

		private void UpdateButtons()
		{
			btnPrev.Enabled = currentStepIndex != 0;

			btnNext.Text = (currentStepIndex == steps.Length - 1) ? "Færdig" : "Næste";
		}


		private void btnPrev_Click(object sender, EventArgs e)
		{
			PrevStep();
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			NextStep();
		}

		private void pnlStepHolderInner_SizeChanged(object sender, EventArgs e)
		{
			activeStep.Height = pnlStepHolderInner.Height - 1;
		}
	}
}
