namespace PharmaTest
{
    public class Medicine : Code
    {
       public string MedicineName { get; set; }

       public string ManufactureName { get; set; }

       protected decimal price;
       protected int qtyStock;
       public string ManufactureDate { get; set; }
       public string ExpiryDate { get; set; }

       private int batchNumber;

       public Medicine(int medicineCode, string medicineName, string manufacturedName, decimal price, int qtyStock, string manufactureDate, string expiryDate, int batchNumber) : base(medicineCode)
       {
           MedicineName = medicineName;
           ManufactureName = manufacturedName;
           Price = price;
           QtyStock = qtyStock;
           ManufactureDate = manufactureDate;
           ExpiryDate = expiryDate;
           BatchNumber = batchNumber;
       }

       public decimal Price
       {
           get { return price; }
           private set {
               if(value > 0.0M)
               {
                   price = value;
               }
           }
       }

       public int QtyStock
       {
           get { return qtyStock;}
           private set {
               if(value > 0)
               {
                   qtyStock = value;
               }
           }
       }

       public int BatchNumber
       {
           get {return batchNumber;}
           private set{
               if(value > 0)
               {
                   batchNumber = value;
               }
           }
       }

       public string Print()
       {
           return $"\nMedicine details\n\n{MedicineCode} {MedicineName} {ManufactureName} {Price:C} {QtyStock} pieces {ManufactureDate} {ExpiryDate} {BatchNumber}\n";
       }

       public string Print(int code)
       {
           
           return $"\nMedicine with code {code} quantity in stock is 30 pieces\n";
       }

       public string Print(int code, string medName)
       {
           return $"\nMedicine with code {code} and of Name {medName} is manufactured on 22-08-2018 and expiring on 22-08-2022\n";
       }

        // public override string ToString()
        // {
        //     return $"{MedicineCode} {MedicineName} {ManufactureName} {Price:C} {QtyStock} pieces {ManufactureDate} {ExpiryDate} {BatchNumber}\n";
       
        // }
    }
}