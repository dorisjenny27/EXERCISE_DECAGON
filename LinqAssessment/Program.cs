namespace LinqAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List used for Grouping
            List<States> states = new List<States>();
            states.Add(new States { stateId = "A1", state = "Abia", capital = "Umuahia" });
            states.Add(new States { stateId = "A1", state = "Adamawa", capital = "Yola" });
            states.Add(new States { stateId = "A1", state = "Akwa-Ibom", capital = "Uyo" });
            states.Add(new States { stateId = "A1", state = "Anambra", capital = "Awka" });
            states.Add(new States { stateId = "A1", state = "Bauchi", capital = "Bauchi" });
            states.Add(new States { stateId = "A1", state = "Bayelsa", capital = "Yenagoa" });
            states.Add(new States { stateId = "A2", state = "Benue", capital = "Makurdi" });
            states.Add(new States { stateId = "A2", state = "Borno", capital = "Maiduguri" });
            states.Add(new States { stateId = "A2", state = "Cross-River", capital = "Calabar" });
            states.Add(new States { stateId = "A2", state = "Delta", capital = "Asaba" });
            states.Add(new States { stateId = "A2", state = "Ebonyi", capital = "Abakaliki" });
            states.Add(new States { stateId = "A2", state = "Edo", capital = "Benin-City" });
            states.Add(new States { stateId = "A3", state = "Ekiti", capital = "Ado-Ekiti" });
            states.Add(new States { stateId = "A3", state = "Enugu", capital = "Enugu" });
            states.Add(new States { stateId = "A3", state = "Gombe", capital = "Gombe" });
            states.Add(new States { stateId = "A3", state = "Imo", capital = "Owerri" });
            states.Add(new States { stateId = "A3", state = "Jigawa", capital = "Dutse" });
            states.Add(new States { stateId = "A3", state = "Kaduna", capital = "Kaduna" });
            states.Add(new States { stateId = "A4", state = "Kano", capital = "Kano" });
            states.Add(new States { stateId = "A4", state = "Katsina", capital = "Katsina" });
            states.Add(new States { stateId = "A4", state = "Kebbi", capital = "Birnin-Kebbi" });
            states.Add(new States { stateId = "A4", state = "Kogi", capital = "Lokoja" });
            states.Add(new States { stateId = "A4", state = "Kwara", capital = "Ilorin" });
            states.Add(new States { stateId = "A4", state = "Lagos", capital = "Ikeja" });
            states.Add(new States { stateId = "A5", state = "Nasarawa", capital = "Lafia" });
            states.Add(new States { stateId = "A5", state = "Niger", capital = "Minna" });
            states.Add(new States { stateId = "A5", state = "Ogun", capital = "Abeokuta" });
            states.Add(new States { stateId = "A5", state = "Ondo", capital = "Akure" });
            states.Add(new States { stateId = "A5", state = "Osun", capital = "Oshogbp" });
            states.Add(new States { stateId = "A5", state = "Oyo", capital = "Ibadan" });
            states.Add(new States { stateId = "A6", state = "Plateau", capital = "Jos" });
            states.Add(new States { stateId = "A6", state = "Rivers", capital = "Port-Harcourt" });
            states.Add(new States { stateId = "A6", state = "Sokoto", capital = "Sokoto" });
            states.Add(new States { stateId = "A6", state = "Taraba", capital = "Jalingo" });
            states.Add(new States { stateId = "A6", state = "Yobe", capital = "Damaturu" });
            states.Add(new States { stateId = "A6", state = "Zamfara", capital = "Gusau" });
            states.Add(new States { stateId = "A6", state = "FCT", capital = "Abuja" });



            Grouping.GroupingExample(states); //Method for groupby
            Inventory(); //Method for Joining
            StateList.StateListExample(); //Method for GroupJoin
           


        }

        static void Inventory()
        {
            //List used for Joining
            List<Item> itemlist = new List<Item>
            {
                new Item { ItemId = 1, ItemDes = "Bag" },
                new Item { ItemId = 2, ItemDes = "Pen" },
                new Item { ItemId = 3, ItemDes = "Book" },
                new Item { ItemId = 4, ItemDes = "Shoe" },
                new Item { ItemId = 5, ItemDes = "Pin" },
            };


            List<Sales> saleslist = new List<Sales>
            {
                new Sales { InvNo = 1, ItemId = 3, Qty = 10 },
                new Sales { InvNo = 2, ItemId = 4, Qty = 20 },
                new Sales { InvNo = 3, ItemId = 5, Qty = 500 },
                new Sales { InvNo = 4, ItemId = 6, Qty = 20 },
                new Sales { InvNo = 5, ItemId = 7, Qty = 100 },
                new Sales { InvNo = 6, ItemId = 8, Qty = 50 },
            };

            Joining.JoiningExample(itemlist, saleslist);
            
        }
    }
}
