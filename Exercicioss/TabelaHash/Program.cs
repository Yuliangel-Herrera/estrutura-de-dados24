// ATIVIDADE TABELA HASH

Dictionary<string, string> 
products = new Dictionary<string, string> 
    { 
        {"4512556", "A5"},
        {"4512559", "A5"}, 
        {"4512553", "A5"}, 
        {"4512551", "A5"},

        {"4512552", "C6"}, 
        {"6458668", "C6"}, 
        {"4512554", "C6"}, 
        {"4512555", "C6"},

        {"5789356", "C3"}, 
        {"5789357", "C3"}, 
        {"5789353", "C3"}, 
        {"5789355", "C3"}, 
        {"5789359", "C3"} 
    }; 
    Console.WriteLine("All products:"); 
    if (products.Count == 0) 
    { 
        Console.WriteLine("Empty"); 
    } 
    else 
    { 
        foreach (KeyValuePair<string, string> product in products) 
        { 
            Console.WriteLine($" - {product.Key}: {product.Value}");
        } 
    } 
    Console.WriteLine(); 
    Console.Write("Search by barcode: "); 
    string? barcode = Console.ReadLine(); 
    if (products.TryGetValue(barcode, out string location)) 
    {
         Console.WriteLine($"The product is in the area {location}."); 
    } 
    else 
    { Console.WriteLine("The product does not exist."); }
