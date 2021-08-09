using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart 
    {
        public List<Item> Items =new List<Item>();
        public static readonly Cart Instance;
    
        public  Cart() { }
            
        public void Add(Item newItem) {
           
            // If this item already exists in our list of items, increase the quantity
            // Otherwise, add the new item to the list
            if (Items.Contains(newItem)) {
                foreach (Item theItem in Items) {
                    if (theItem.Equals(newItem)) {
                        theItem.Quantity++;
                        return;
                    }
                }
            } else {
                
                Items.Add(newItem);
            }
        }
    
        
        // SetItemQuantity() - Changes the quantity of an item in the cart
        
     /*   public void SetItemQuantity(int productId, int quantity) {
            // If we are setting the quantity to 0, remove the item entirely
            if (quantity == 0) {
                RemoveItem(productId);
                return;
            }
    
            // Find the item and update the quantity
            Item updatedItem = new Item{ new Product{ Id=productId}};
    
            foreach (Item item in Items) {
                if (item.Equals(updatedItem)) {
                    item.Quantity = quantity;
                    return;
                }
            }
        }
    */

        // RemoveItem() - Removes an item from the shopping cart
        
        public void RemoveItem(int productId) {   
            var found = Items.Find(x => x.ProductId == productId);
            if(found != null) Items.Remove(found);
        }
    
  
        // GetSubTotal() - returns the total price of all of the items
        /*public double GetSubTotal() {
            double subTotal = 0;
            foreach (Item item in Items)
                subTotal += item.UnitPrice * item.Quantity;
    
            return subTotal;
        }*/
    }
}