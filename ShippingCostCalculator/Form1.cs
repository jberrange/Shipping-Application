using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// Description: The program inputs the dimensions and mass of a package, and calculates package size and shipping cost
// Author:      James Berrange
// Notes:       You may modify the file XMLPackageDefinitions.xml to create alter and delete package size definitions.
//              The XML records are processed serially and must therefore be ordered.
// Date:        2016/11/15

namespace Shipping
{


    public partial class frmCostCalculator : Form
    {

        const int PACKAGE_SIZE_INVALID = -1;
        const int PACKAGE_SIZE_VALID = 0;
        const int PACKAGE_SIZE_OVERWEIGHT = 1;

        public frmCostCalculator()
        {
            InitializeComponent();
        }

        private void frmCostCalculator_Load(object sender, EventArgs e)
        {
            //hide all result fields when form is first loaded
            lblErrorText.Visible = false;
            lblErrorStatus.Visible = false;
            lblPackageSize.Visible = false;
            lblPackageSizeLabel.Visible = false;
            lblShippingCost.Visible = false;
            lblShippingCostLabel.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //declare and initialise variables
                var packageName = "";
                var packageCost = "";
                var packageMaxMass = 0;
                int packageStatus;
                var uLength = txtLength.Text;
                var uWidth = txtWidth.Text;
                var uHeight = txtHeight.Text;
                var uMass = txtMass.Text;
                
                //instatiate class and determine package size and cost
                PackageComponent packageManager = new PackageComponent();
                packageStatus = packageManager.GetPackageCost(Convert.ToInt32(uLength), Convert.ToInt32(uWidth), Convert.ToInt32(uHeight), Convert.ToInt32(uMass), out packageName, out packageCost, out packageMaxMass);                
                
                //display results to user
                lblErrorText.Visible = false;
                lblErrorStatus.Visible = true;
                lblPackageSize.Visible = false;
                lblPackageSizeLabel.Visible = false;
                lblShippingCostLabel.Visible = false;
                lblShippingCost.Visible = false;

                switch (packageStatus)
                {
                    case PACKAGE_SIZE_VALID:
                        //package can be handled - show package size and cost
                        lblPackageSize.Text = packageName;
                        lblShippingCost.Text = packageCost;
                        lblPackageSize.Visible = true;
                        lblShippingCost.Visible = true;
                        lblPackageSizeLabel.Visible = true;
                        lblShippingCostLabel.Visible = true;
                        lblErrorStatus.Visible = false;
                        lblErrorText.Visible = false;
                        break;
                    case PACKAGE_SIZE_OVERWEIGHT:
                        //package too heavy - inform user
                        lblErrorStatus.Text = "We cannot accommodate " + packageName + "-Sized packages that weigh more than " + packageMaxMass + " kilograms";
                        break;
                    case PACKAGE_SIZE_INVALID:
                        //package size not valid and cannot be handled - inform user
                        lblErrorStatus.Text = "We cannot accommodate your specified package size";
                        break;
                }
            }
            catch (Exception ee)
            {
                //for purposes of project, just show a generic error here....
                lblErrorStatus.Visible = true;
                lblErrorStatus.Text = "An unexpected error occurred. Please make sure you have captured valid measurements.";
                lblErrorText.Visible = true;
                lblErrorText.Text = ee.Message;
            }
        }
    }
}
