using System;
using System.Data;


public class PackageComponent
{

    const int PACKAGE_SIZE_INVALID = -1;
    const int PACKAGE_SIZE_VALID = 0;
    const int PACKAGE_SIZE_OVERWEIGHT = 1;


    public int GetPackageCost(int customerPackageLength, int customerPackageWidth, int customerPackageHeight, int customerPackageMass, out string uName, out string uCost, out int outMass)
    {
        //declare and initialise variables
        var packageLength = 0;
        var packageWidth = 0;
        var packageHeight = 0;
        var packageMass = 0;
        var packageName = "";
        var packageCost = "";
        var outName = "";
        var outCost = "";
        int pStatus = PACKAGE_SIZE_INVALID;
        
        
        //load the package definition from the XML into a Data Table object
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        //string xmlPath = "C:\\Users\\Gillian\\Documents\\Visual Studio 2012\\Projects\\WindowsFormsApplication4\\XMLPackageDefinitions.xml";
        //string xmlPath = "C:\\Users\\Gillian\\Documents\\Visual Studio 2012\\Projects\\WindowsFormsApplication4\\XMLPackageDefinitions.xml";
        //ds.ReadXml(xmlPath);


        try
        {
            string xmlPath ="resources\\XMLPackageDefinitions.xml";
            ds.ReadXml(xmlPath );
            dt = ds.Tables[0];
        }
        catch (Exception e)
        {
            throw e;
        }

        //iterate through package collection until a valid package is found
        try
        {
            foreach (DataRow dr in dt.Rows)
            {
                packageLength = Convert.ToInt32(dr["PackageLength"].ToString());
                packageWidth = Convert.ToInt32(dr["PackageWidth"].ToString());
                packageHeight = Convert.ToInt32(dr["PackageHeight"].ToString());
                packageMass = Convert.ToInt32(dr["PackageMass"].ToString());
                packageName = dr["PackageName"].ToString();
                packageCost = dr["PackageCost"].ToString();

                if (customerPackageLength <= packageLength && customerPackageWidth <= packageWidth && customerPackageHeight <= packageHeight)
                {
                    outName = packageName;
                    if (customerPackageMass > packageMass)
                    {
                        outCost = "Too heavy";
                        pStatus = PACKAGE_SIZE_OVERWEIGHT;

                    }
                    else
                    {
                        outCost = packageCost;
                        pStatus = PACKAGE_SIZE_VALID;
                    }
                    break;
                }
            }

            outMass = packageMass;
            uName = outName;
            uCost = outCost;
            return pStatus;
        }
        catch (Exception e)
        {
            //Exception e = new Exception();
            //e. = "Sorry - something went wrong!";
            throw e;
        }
    }

}
