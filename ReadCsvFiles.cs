using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using AMPS.Data.Models;
using CSVToPAM;
using AMPS.Utilities;
using System.Configuration;
using PolicyServices;

namespace AMPS.Data.Models
{
    public class ReadCsvFiles
    {

        public void ReadCSVFiles()
        {
            string path = @ConfigurationManager.AppSettings["CSV_PAMXML"];
            string target = @ConfigurationManager.AppSettings["CSV_PAMXMLBackUp"];
            CreateFolderAndFile crtFldr = new CreateFolderAndFile();
            crtFldr.MoveCurrentFolderToBackupFolder(path, target);
            crtFldr.CreateDirectory(path);

            //File.SetAttributes("CSUUW - MTH CSU GL Audit Report.csv", FileAttributes.Normal);
            List<CSUValues> values = File.ReadAllLines("CSUUW - MTH CSU GL Audit Report.csv", Encoding.UTF8)
                                          .Skip(1)
                                          .Select(v => CSUValues.FromCsv(v))
                                          .ToList();
        }
    }

    public class CSUValues
    {
        //internal DateTime PolicyEffDate;
        public string AgencyNbr;
        public string PolicyNbr;
        public string InsNm;
        public DateTime polExpDt;
        public string mailingdAdd;
        public string displayLocNmbr;
        public string riskAddr;
        public string riskZip;
        public string clsCode;
        public string prmBasisDesc;
        public string glExpsrAmt;
        public string premium;
        public string name;

        public static CSUValues FromCsv(string csvLine)
        {
            

            string[] values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            if (values.Length < 2)
            {
                csvLine = csvLine.Replace("\t", ",");
                values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            }
            // string[] value = csvLine.Split(',');

            else
            {
                values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            }
            CSUValues csuvalues = new CSUValues();
            Console.WriteLine(values.Length);
            List<CSUValues> CSUObj = new List<CSUValues>();
            if (values.Length > 4)
            {
                try
                {
                    //csuvalues.PolicyEffDate = Convert.ToDateTime(values[0]);
                    csuvalues.AgencyNbr = Convert.ToString(values[1]);
                }
                catch (Exception ex)
                {
                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_1_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.PolicyNbr = Convert.ToString(values[2]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_2_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.InsNm = Convert.ToString(values[3]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_3_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.polExpDt = Convert.ToDateTime(values[4]);
                }
                catch (Exception)
                {
                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_4_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.mailingdAdd = Convert.ToString(values[5]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_5_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.displayLocNmbr = Convert.ToString(values[6]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_6_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.riskAddr = Convert.ToString(values[7]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_7_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.riskZip = Convert.ToString(values[8]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_8_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.clsCode = Convert.ToString(values[9]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_9_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.prmBasisDesc = Convert.ToString(values[10]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_10_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.glExpsrAmt = Convert.ToString(values[11]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_11_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.premium = Convert.ToString(values[12]);
                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_12_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
                try
                {
                    csuvalues.name = Convert.ToString(values[13]);

                }
                catch (Exception)
                {

                    File.WriteAllText(@"E:\TFS\EnterpriseWebServices\AMPS\AMPSRewrite\Read_Raw_CSU_Policy_Data\Error\ErrorIn_13_Value" + Convert.ToString(values[12]) + ".txt", Convert.ToString(values[1]));
                }
            }
            //CSUObj.Add(csuvalues);
            PolicyServices.GetCSVToPAMTranslator getCSVToPAMTranslator = new GetCSVToPAMTranslator();
            getCSVToPAMTranslator.GetCsvToPamTranslatorAndSendToAuSuM(csuvalues);

            return csuvalues;
        }
    }
}
