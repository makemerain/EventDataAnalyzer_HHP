using LinqToExcel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDataAnalyzer_HHP.ApplicationFunctions
{
    public  class ExcelFactory
    {       
        
            
           

            public ExcelFactory(string path)
            {
              
                this._QueryFactoryExcelConnection = new ExcelQueryFactory(path);
            }

        private  ExcelQueryFactory _QueryFactoryExcelConnection;
        public ExcelQueryFactory UrlConnection
            {
                get
                {
                    return _QueryFactoryExcelConnection;
                }
            }
        }

    }

