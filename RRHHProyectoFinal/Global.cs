using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHHProyectoFinal
{
    static class Global
    {
        private static string _GlobalUsername = "";
        private static int _GlobalUserID = 0;
        private static int _GlobalPersonID = 0;
        private static int _GlobalCandidatoID = 0;

        public static string GlobalUserName
        {
            get { return _GlobalUsername; }
            set { _GlobalUsername = value; }
        }

        public static int GlobalUserID
        {
            get { return _GlobalUserID; }
            set { _GlobalUserID = value; }
        }


        public static int GlobalPersonID
        {
            get { return _GlobalPersonID; }
            set { _GlobalPersonID = value; }
        }

        public static int GlobalCandidatoID
        {
            get { return _GlobalCandidatoID; }
            set { _GlobalCandidatoID = value; }
        }
    }
}
