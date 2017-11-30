using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class InventoryStore
    {
        private List<InventoryItem> LocalInventory = new List<InventoryItem>();

        public InventoryStore() {
            this.LocalInventory.Add(new InventoryItem() { Ammount = 3, Price = 33.95M, Description = "Pencil" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 1, Price = 00.39M, Description = "Notebook" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
            this.LocalInventory.Add(new InventoryItem() { Ammount = 9, Price = 15.00M, Description = "Whiteboard marker" });
        }

        public List<InventoryItem> GetInventory() {
            return this.LocalInventory;
        }
    }
}
