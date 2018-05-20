using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    class Inventory
    {
        List<InventoryItem> inventoryList = new List<InventoryItem>();
        private char delimiter = ',';
        private string header1;
        private string header2;


        public List<InventoryItem> ReadInventoryFile()
        {
            try
            {
                //opens inventory file
                StreamReader streamReader = new StreamReader(File.OpenRead("inventory.csv"));

                //skips header and blank lines in beginning of file
                header1 = streamReader.ReadLine();
                header2 = streamReader.ReadLine();

                

                //reads file to end, creating new InventoryItem objects to add to the inventory list
                while (!streamReader.EndOfStream)
                {
                    string inventoryLine = streamReader.ReadLine();
                    string[] inventoryStrings = inventoryLine.Split(delimiter);

                    InventoryItem inventoryItem = new InventoryItem();
                    inventoryItem.Name = inventoryStrings[0];
                    inventoryItem.Model = inventoryStrings[1];
                    inventoryItem.Type = inventoryStrings[2];
                    inventoryItem.Quantity = int.Parse(inventoryStrings[3]);
                    inventoryItem.Msrp = decimal.Parse(inventoryStrings[4]);
                    inventoryItem.SalePrice = decimal.Parse(inventoryStrings[5]);

                    inventoryList.Add(inventoryItem);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            return inventoryList;

        }

        public void SaveInventoryFile()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(File.OpenWrite("inventory.csv"));

                streamWriter.WriteLine(header1);
                streamWriter.WriteLine(header2);

                foreach (InventoryItem inventoryItem in inventoryList)
                {
                    streamWriter.WriteLine(inventoryItem.Name + "," + inventoryItem.Model + "," + inventoryItem.Type + "," + inventoryItem.Quantity + ","
                                           + inventoryItem.Msrp + "," + inventoryItem.SalePrice);
                }

               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }

        public void DeleteItem(InventoryItem inventory)
        {


        }

        public void AddItem()
        {


        }

        public void UpdateItem(InventoryItem inventoryItem)
        {


        }
    }
}
