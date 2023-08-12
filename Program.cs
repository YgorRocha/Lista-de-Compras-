// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

 class Program{
        static void Main(){
            
            List<string> ShoppingList = new List<string>();

            while(true){
                Console.WriteLine("1 - Show shopping list:  ");
                Console.WriteLine("2 - Add to shopping list:  ");
                Console.WriteLine("3 - Remove to shopping list:  ");
                Console.WriteLine("4 - exit:  ");

                string? choice = Console.ReadLine();

                switch(choice){

                    case "1": 
                    ShowingShoppingList(ShoppingList);
                    break;

                    case "2": 
                    Console.WriteLine("What items you would like to add to your shopping list");
                    string? selectedItem = Console.ReadLine();
                    AddingItems(ShoppingList, selectedItem);
                    break;

                    case "3":
                    Console.WriteLine("Type the number you would like to romove");
                    ShowingShoppingList(ShoppingList);

                    if(int.TryParse(Console.ReadLine(), out int indice)){
                        RemoveItem(ShoppingList, indice);
                    }
                    else{
                        Console.WriteLine("Make sure you have a valid number");
                    }
                    break;

                    case "4":
                    Console.WriteLine("Exiting program"); 
                    return;

                    default:
                    Console.WriteLine("Invalid Option. Please, choose a valid option.");
                    break;               
                    
                }
            }
        }
    static void ShowingShoppingList(List<string> list)
    {
        Console.WriteLine("Lista de Compras:   ");
        for(int i = 0; i < list.Count; i++){
            Console.WriteLine($"{i + 1}. {list[i]}");
        }
    }

    static void AddingItems(List<string> list, string item){
        list.Add(item);
        Console.WriteLine($"'{item}' It was added to the list");
    }

    static void RemoveItem(List<string> list, int indice){
        if( indice >= 1 && indice <= list.Count){

            string removedItem = list[indice -1];
            list.RemoveAt(indice - 1);
            Console.WriteLine($"'{removedItem}' It was removed from the list");
        }

        else{
            Console.WriteLine("Invalid indece. Make sure you have a valid item");
        }
    }

}






