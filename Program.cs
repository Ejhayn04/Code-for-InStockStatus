// K2714
//CIS-199-01-4228
//11/30/2022
// This code explores the creation of reusable classes and separte console applications that creates a list of objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
   public class Product //Establishing a new class
    {

        private string Supplier_Name;//Establishing my backing code
        private string Product_Name;//Establishing my backing code
        private int Product_ID;//Establishing my backing code
        private string Product_Type;//Establishing my backing code
        private double Product_Price;//Establishing my backing code
        private int Aisle_Location;//Establishing my backing code
        private bool In_Stock_Status;//Establishing my backing code
        public string SupplierName { get; set; }//estblishing the supplier name string and prompting the get/set modifier
        public string ProductName { get; set; } //estblishing the Product name string and prompting the get/set modifier
        public int ProductID ////estblishing the Product ID and prompting the get/set modifier
        {
            get { return Product_ID; }//Return the product id through get 
            set // Establishing my set method
            {
                if (value >= 100000 || value <= 999999)//Using an if statement to make sure the value is between 100000 and 999999
                {
                     Product_ID = value;//Making sure the value equals the product ID
                }
                else //else statement just incase the user enters an incorrect value
                {
                    Product_ID = 0; //Product ID to default value
                }
            }
        }
        public string ProductType //estblishing the Product Type string and prompting the get/set modifier
        {
            get { return Product_Type; } //Return the product id through get  
            set //establihshing set
            {
                Product_Type = value;//Making sure the value equals the Product Type
            }
        }
        public double ProductPrice//estblishing the Product Price double and prompting the get/set modifier
        {
            get { return Product_Price; } //Return the product id through get 
            set//establihshing set
            {
                if(value >= 0)//Making sure the users value is greater than 0
                {
                    Product_Price = value;//Making sure the value equals the Product Price
                }
                else//else statement just incase the user enters an incorrect value
                {
                    Product_Price = 0;//Product Price to default value
                }
            }
        }
        public int AisleLocation//estblishing the Aisle Location and prompting the get/set modifier
        {
            get { return Aisle_Location; }//Return the product id through get 
            set//establihshing set
            {
                if (value <= 1 || value <= 20)//Using an if statement to make sure the value is between 1 and 20
                {
                    Aisle_Location = value; //Making sure the user value equals the Aisle Location
                }
                else//else statement just incase the user enters an incorrect value
                {
                    Aisle_Location = 0;//Product Price to default value
                }
            }
        }
        public bool InStockStatus;//Bool to see if product is in stock
        public void InStock() //Establishing a void to not return if the product is in stock
        {
         In_Stock_Status = true;//If in stock status is true, run the public void InStock()
        }
        public void OutofStock()//Establishing a void to not return if the product is out of stock
        {
            In_Stock_Status = true;//If in stock status is true, run the public void Out of Stock()
        }
        public bool IsOutofStock() //Bool to see if product is out of stock
        {
            return In_Stock_Status;// If outofstock return the the in stock status as false.
        }
        public override string ToString() // Returning the string with no paramters
        {
            return $"Supplier: {Supplier_Name} " + Environment.NewLine + // Establishing new string and adding a new line with Environmental New Line
            $"Product: {Product_Name} " + Environment.NewLine +// Establishing new string and adding a new line with Environmental New Line
            $"ID: {Product_ID} " + Environment.NewLine +// Establishing new string and adding a new line with Environmental New Line
            $"Product Type: {Product_Type} " + Environment.NewLine +// Establishing new string and adding a new line with Environmental New Line
            $"Price: {Product_Price} " + Environment.NewLine +// Establishing new string and adding a new line with Environmental New Line
            $"Aisle: {Aisle_Location} " + Environment.NewLine +// Establishing new string and adding a new line with Environmental New Line
            $"In Stock?: {IsOutofStock()} " + Environment.NewLine;// Establishing new string and adding a new line with Environmental New Line

        }
        public Product (string Supplier_Name, string Product_Name,int Product_ID, string Product_Type, double Product_Price, int Aisle_Location)// Establisihing the product variables in order for the product to be able to contain a 6 paramater constructor 
        {
            this.Supplier_Name = Supplier_Name;//Using this to establish the paramter
            this.Product_Name = Product_Name; //Using this to establish the paramter
            this.Product_ID = Product_ID;//Using this to establish the paramter
            this.Product_Type = Product_Type;//Using this to establish the paramter
            this.Product_Price = Product_Price; //Using this to establish the paramter
            this.Aisle_Location = Aisle_Location;//Using this to establish the paramter
            this.In_Stock_Status = false;//Using this to establish the paramter


        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] Products = new Product[5];//Establishing my array and range
            Products[0] = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);// Creating my first array with the six paramters
            Products[1] = new Product("Mtn Dew", "Drink", 675135, "Beverage", 3.60, 5);// Creating my second array with the six paramters
            Products[2] = new Product("Nathan's Hotdogs", "Food", 685513, "Food", 3.86, 6);// Creating my third array with the six paramters
            Products[3] = new Product("Kelloggs", "Food", 690000, "Food", 3.99, 7);// Creating my fourth array with the six paramters
            Products[4] = new Product("Tysons", "Tenders", 669540, "Meat", 3.86, 9);// Creating my fifth array with the six paramters

            Console.WriteLine("List of Products We Sell:"+Environment.NewLine+"-------------------------");//Telling the user the list of products we sell
            PrintAll(Products);//Making sure all my arrays print to the console.

            Products[0].InStock();//Testing if the product is in stock
            Products[0].ProductPrice = 3.50;//Details for the test
            Products[0].ProductID = 675134;//Details for the test

            Products[1].InStock();//Testing if the product is in stock
            Products[1].ProductPrice = 4.99;//Details for the test
            Products[1].AisleLocation = 5;//Details for the test

            Products[2].InStock();//Testing if the product is in stock
            Products[2].ProductID = 685513;//Details for the test
            Products[2].ProductType = "Food";//Details for the test

            Products[3].ProductPrice = 3.99;//Details for the test
            Products[3].ProductType = "Food";//Details for the test

            Products[4].AisleLocation = 9;//Details for the test
            Products[4].ProductPrice = 5.49;//Details for the test

            Console.WriteLine("After Changes"+Environment.NewLine+"-------------"); //Printing to the console after all products update
            PrintAll(Products);// Making sure everything in my test prints

        }
        static void PrintAll(Product[] Products) // Calling all my products to print out the orgianl data
        {
            for(int sell = 0; sell < Products.Length; sell++)//Establishing a for loop to print all my original data to the console.
            {
                Console.WriteLine(Products[sell].ToString());//Printing my data to the console.
            }
        }
    }
}
