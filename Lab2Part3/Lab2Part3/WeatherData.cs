using System;

namespace Lab2Part3
{
    public class WeatherData
    {
        public decimal Day;
        public decimal MaxTemperature;
        public decimal MinTemperature;
        public decimal AverageTemperature;
        public decimal HDDay;
        public double AverageDP;
        public string OneHrP;
        public double TPcpn;
        public string WxType;
        public decimal PDir;
        public double AverageSp;
        public decimal Dir;
        public decimal MaxS;
        public double SkyC;
        public decimal MaxR;
        public decimal MinR;
        public double AverageSLP;

        public WeatherData(string[] data)
        {
            this.Day = Convert.ToDecimal(data[0]);
            this.MaxTemperature = Convert.ToDecimal(data[1]);
            this.MinTemperature = Convert.ToDecimal(data[2]);
            this.AverageTemperature = Convert.ToDecimal(data[3]);
            this.HDDay = Convert.ToDecimal(data[4]);
            this.AverageDP = Convert.ToDouble(data[5]);
            if (data[6] == "0")
            {
                this.OneHrP = "No data";
            }
            else
            {
                this.OneHrP = data[6];
            }
            this.TPcpn = Convert.ToDouble(data[7]);
            if (data[8] == "0")
            {
                this.WxType = "No data";
            }
            else
            {
                this.WxType = data[8];
            }
            this.PDir = Convert.ToDecimal(data[9]);
            this.AverageSp = Convert.ToDouble(data[10]);
            this.Dir = Convert.ToDecimal(data[11]);
            this.MaxS = Convert.ToDecimal(data[12]);
            this.SkyC = Convert.ToDouble(data[13]);
            this.MaxR = Convert.ToDecimal(data[14]);
            this.MinR = Convert.ToDecimal(data[15]);
            this.AverageSLP = Convert.ToDouble(data[16]);
        }

        public string GetImportantData()
        {
            return this.Day.ToString()+" "+this.MaxTemperature.ToString()+" "+this.MinTemperature.ToString();
        }

    }
}
