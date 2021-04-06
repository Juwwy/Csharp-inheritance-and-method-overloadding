namespace PharmaTest
{
    public class Sales : Code
    {
        private int qtySold;
        public int PlannedSales { get; set; }
        private int actualSales;
        public string Region { get; set; }

        

        public Sales(int medicineCode, int qtySold, int plannedSales, int actualSales, string region) : base(medicineCode)
        {
            QtySold = qtySold;
            PlannedSales = plannedSales;
            ActualSales = actualSales;
            Region = region;
        }

        public int QtySold
        {
            get { return qtySold; }
            private set {
                if(value > 0)
                {
                    qtySold = value;
                }
            }
        }

        public int ActualSales
        {
            get { return actualSales; }
            private set {
                if(value > 0)
                {
                    actualSales = value;
                }
            }
        }

        public string Display()
        {
            return $"\nSales display information\ncode:{MedicineCode}\nQuantity sold: {QtySold}\nPlanned sale: {PlannedSales}\nActual sales: {ActualSales}\nRegion: {Region}";
        }

        public string Display(int code,int plannedSales=500, int actualSales = 120)
        {
            int salesDiff = plannedSales - actualSales;
            return $"\nThe difference between the planned sales and actual sales of medicine with code {code} is: {salesDiff} \n";
        }

        
    }
}