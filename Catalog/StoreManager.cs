 namespace Catalog
{


 public class StoreManager{
       public static void TakeThree(){
            int[] numbers={23,56,77,89,99,90};
            var first3numbers=numbers.Take(3);
            foreach(var n in first3numbers){
                Console.WriteLine(n);
            }
        }

        public static void Skip(){
            int[] numbers={34,56,77,78,98,90,99,12,10,9};
            var allButFirst4numbers=numbers.Skip(4);
            Console.WriteLine("All but first 4 numbers");
            foreach(var n in allButFirst4numbers){
                Console.WriteLine(n);
            }

        }

        public static IEnumerable<String>GetFruitsOrderBy(){
            string[] fruits={"cherry","mango","apple","banana","blueberry"};
            //LINQ
            var sortedFruits=from fruit in fruits orderby fruit descending select fruit;
            return sortedFruits;
            
        }

        public static void SimpleUnion(){
            int[] numA={0,2,4,6,7,8,9,10};
            int[] numB={1,3,5,6,16,17,19};

            var uniqueNumbers=numA.Union(numB);
            Console.WriteLine("Unique numbers from both the arrays:");
            foreach(var n in uniqueNumbers){
                Console.WriteLine(n);
            }

        }
        public static void SimpleIntersect(){
            int[] numA={0,2,4,6,7,8,9,10};
            int[] numB={1,3,5,6,7,8,16,17,19};

            var commonNumbers=numA.Intersect(numB);
            Console.WriteLine("Common numbers from both the arrays:");
            foreach(var n in commonNumbers){
                Console.WriteLine(n);
            }

        }

        public static void SimpleExcept(){
            int[] numA={0,2,4,6,7,8,9,10};
            int[] numB={1,3,5,6,7,8,16,17,19};
            IEnumerable<int> aOnlyNumbers=numA.Except(numB);
            Console.WriteLine("Numbers in first array but not in second array:");
            foreach(var n in aOnlyNumbers){
                Console.WriteLine(n);
            }
             
        }

        public static void ToSimpleList(){
            string[] words={"cherry","apple","blueberry"};
            var sortedWords= from w in words orderby w select w;
            var wordList=sortedWords.ToList();
            Console.WriteLine("The sorted word list");
            foreach(var w in wordList){
                Console.WriteLine(w);
            }
        }

        public static void ToDictionary(){
            var scoreRecords= new[]{
                new {Name="Ankur",Score = 89},
                new {Name="Vishwambhar",Score = 91},
                new {Name="Rutuja",Score = 90},
                new {Name="Tukaram",Score = 80},
                new {Name="Neha",Score = 82},
            };
            var scoreRecordsDict=scoreRecords.ToDictionary(sr => sr.Name);
            return scoreRecordsDict;

        }

        public static IEnumerable<Product> GetAllProducts(){
            List<Product> allProducts=new List<Product>();
            allProducts.Add(new Product{Id= 101,Title="Gerbera",Quantity=20000,Description="Beautiful Flower",Category="Flower",UnitPrice=30,Likes=11000,ImageUrl="images/Gerbera.jpg"});
            allProducts.Add(new Product{Id= 102,Title="Tulip",Quantity=20500,Description="Kashmiri Flower",Category="Flower",UnitPrice=150,Likes=75000,ImageUrl="images/Tulip.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Rose",Quantity=20050,Description="Wedding Flower",Category="Flower",UnitPrice=50,Likes=45600,ImageUrl="images/Rose.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Jasmine",Quantity=23000,Description="Beautiful Flower",Category="Flower",UnitPrice=55,Likes=35000,ImageUrl="images/Jasmine.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Lily",Quantity=0,Description="Beautiful Flower",Category="Flower",UnitPrice=100,Likes=45000,ImageUrl="images/Lily.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Croton",Quantity=25000,Description="Indoor Plant",Category="Plant",UnitPrice=60,Likes=19000,ImageUrl="images/Croton.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Coconut",Quantity=24000,Description="Best tree",Category="Tree",UnitPrice=80,Likes=18000,ImageUrl="images/Coconut.jpg"});
            allProducts.Add(new Product{Id= 101,Title="Mango",Quantity=21000,Description="Best fruit",Category="Fruit",UnitPrice=90,Likes=16000,ImageUrl="images/Mango.jpg"});

            return allProducts;
        }
         public static IEnumerable<Product> GetAllProductsFromDatabase(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic
            //Querying against mySQL Database.
            return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsFromJSONFile(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic using JSON Serilization
            //Querying against mySQL Database.
            return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsFromMongoDB(){
            List<Product> allProducts=new List<Product>();
            //Data Access Logic using some MongoDB Connector. 
            //Querying against MongoDB Database.
            return allProducts;
        }
        
        public static IEnumerable<Product> GetAllProductsOrderBy(){
            //IEnumerable<Product> products= GetAllProducts();
            IEnumerable<Product> products= GetAllProductsFromMongoDB();
            var sortedProducts=from product in products orderby product.Quantity select product;
            return sortedProducts;
        }   
        
        public  static IEnumerable<Product> GetSoldOutProducts(){
                IEnumerable<Product> products= GetAllProducts();
                var soldOutProducts=from prod in products where  prod.Quantity = 0 select prod;
                return soldOutProducts; 
        }

        public  static IEnumerable<Product> GetProductsInStockLessThan(int amount){
                IEnumerable<Product> products= GetAllProducts();
                var expensiveInStockProducts=from prod in products 
                                             where  prod.Quantity > 0 & prod.UnitPrice> amount
                                             select prod;
                return expensiveInStockProducts; 
        }

        public static dynamic GetProductDetails(){
                IEnumerable<Product> products= GetAllProducts();
                var productInfos= from prod in products
                                  select new { prod.Title, prod.Description, prod.UnitPrice,prod.Quantity};
                return productInfos;
        }

        public  static IEnumerable<Product> GetProductsDistinct(){
                IEnumerable<Product> products= GetAllProducts();
                var uniqueItems=(from prod in products 
                                             select prod.Title).Distinct();
                                            
                return uniqueItems; 
        }

        public  static IEnumerable<Product> GetProductsCount(){
                IEnumerable<Product> products= GetAllProducts();
                var categoryCounts=from prod in products 
                                 group prod by prod.Category into prodGroup
                                 select new { Category = prodGroup.key, GetProductsCount=prodGroup.Count()};
                                            
                return categoryCounts; 
        }
   


}

}