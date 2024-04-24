using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2_2 {
    internal class Converter {
        double usdPer1Hryvna, eurPer1Hryvna, gbpPer1Hryvna;

        public Converter(double usdPer1Hryvna, double eurPer1Hryvna, double gbpPer1Hryvna) {
            this.usdPer1Hryvna = usdPer1Hryvna;
            this.eurPer1Hryvna = eurPer1Hryvna;
            this.gbpPer1Hryvna = gbpPer1Hryvna; 
        }

        public double USD2Hryvna(double usdAmount) {
            return usdAmount / usdPer1Hryvna;
        }

        public double EUR2Hryvna(double eurAmount) {
            return eurAmount / usdPer1Hryvna;
        }

        public double GBP2Hryvna(double gbpAmount) {
            return gbpAmount / usdPer1Hryvna;
        }

        public double Hryvna2USD(double hryvnaAmount) {
            return hryvnaAmount * usdPer1Hryvna;
        }

        public double Hryvna2EUR(double hryvnaAmount) {
            return hryvnaAmount * eurPer1Hryvna;
        }

        public double Hryvna2GBP(double hryvnaAmount) {
            return hryvnaAmount * gbpPer1Hryvna;
        }
    }
}

