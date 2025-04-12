using OfficeOpenXml;
using LinqToExcel;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using EventDataAnalyzer_HHP.ApplicationFunctions;
using System.Windows.Media.Media3D;
using System.Linq;

namespace EventDataAnalyzer_HHP.Data.RawData
{
    public class GetHHPeventDetailList
    {
        public GetHHPeventDetailList(string eventFileInfo, bool pressureConversion,
            DateTime startRecordTime, DateTime endRecordTime, short rowBeign, short columnBegin, string dataSheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            _EventFileInfoPath = eventFileInfo;
            _PressureConversion = pressureConversion;
            _StartRecordTime = startRecordTime;
            _EndRecordTime = endRecordTime;
            _RowBeign = rowBeign;
            _ColumnBegin = columnBegin;
            _HHPeventDataModel = new HHPeventDataModel();
            _ExcelConnectionFactory = new ExcelFactory(_EventFileInfoPath);
            _DatasheetName = dataSheetName;
        }

        private string _EventFileInfoPath { get; set; }
        private bool _PressureConversion = false;
        private DateTime _StartRecordTime;
        private DateTime _EndRecordTime;
        private HHPeventDataModel _HHPeventDataModel = null;
        private List<HHPeventDataModel> _HHPeventdataList = new List<HHPeventDataModel>();
        private Int16 _RowBeign = 0;
        private Int16 _ColumnBegin = 0;
        private String _DatasheetName;

        // Query factory
        private ExcelFactory _ExcelConnectionFactory;




        /// <summary>
        /// Get the event data file
        /// </summary>
        private Boolean FileVerificationSuccessful()
        {
            if (!File.Exists(_EventFileInfoPath))
            {
                throw new Exception("Event data file not exists");
            }
            else
            {
                return true;
            }


        }



        /// <summary>
        /// Read excel file to List of model
        /// Between the read times only
        /// </summary>
        /// <returns>List of event data rows</returns>

        public List<HHPeventDataModel> Get_HHPeventdataTask()
        {

            if (!FileVerificationSuccessful())
            {
                return null;
            }

            var excel = new ExcelQueryFactory(_EventFileInfoPath);
            var RowsCount = excel.Worksheet<HHPeventDataModel>(0).Count();

            // Map Columns
            excel.AddMapping<HHPeventDataModel>(x => x.EventDateTime, "EVENTTIME");
            excel.AddMapping<HHPeventDataModel>(x => x.DistanceTravelled, "DISTANCE");
            excel.AddMapping<HHPeventDataModel>(x => x.Speed, "SPEED");
            excel.AddMapping<HHPeventDataModel>(x => x.TEBE, "TEBE");
            excel.AddMapping<HHPeventDataModel>(x => x.PowerKW, "POWER");
            excel.AddMapping<HHPeventDataModel>(x => x.BPpressure, "BPP");
            excel.AddMapping<HHPeventDataModel>(x => x.BCpressure, "BCP");
            excel.AddMapping<HHPeventDataModel>(x => x.TL24, "TL24T");
            excel.AddMapping<HHPeventDataModel>(x => x.IsGFenabled, "GF");
            excel.AddMapping<HHPeventDataModel>(x => x.ReverserPosition, "RV");
            excel.AddMapping<HHPeventDataModel>(x => x.ThrottlePosition, "TH");
            excel.AddMapping<HHPeventDataModel>(x => x.IsHorn, "HRN");
            excel.AddMapping<HHPeventDataModel>(x => x.IsHLshorthoodBurning, "HLSH");
            excel.AddMapping<HHPeventDataModel>(x => x.IsHLlonghoodBurning, "HLLH");
            excel.AddMapping<HHPeventDataModel>(x => x.IsPCSenabled, "PCS");
            excel.AddMapping<HHPeventDataModel>(x => x.IsPenaltyBrakeApplied, "PB");
            excel.AddMapping<HHPeventDataModel>(x => x.STGBCL, "STGBCL");
            excel.AddMapping<HHPeventDataModel>(x => x.IsMomoryFreezed, "MFRZ");
            excel.AddMapping<HHPeventDataModel>(x => x.EventCode, "EVENTCODE");


            var Qlist = from Q in excel.Worksheet<HHPeventDataModel>(_DatasheetName)                                             
                        select Q;
            // where Q.EventDateTime >= _StartRecordTime && Q.EventDateTime <= _EndRecordTime  

            if (Qlist.Count() >= 0)
            {
                MessageBox.Show(Qlist.Count().ToString());
                return Qlist.ToList();
            } return null;
            


        }

    }
}


    





    
