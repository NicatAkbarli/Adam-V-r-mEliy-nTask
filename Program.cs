using System;
using System.Linq;





string[] values = "salam salam salam salam salam salanm salsma ala ala ala ala ala ala ala ala ala ala ala".Split(' ');
var counts = new Dictionary<string, int>();

foreach (string value in values) { 
 
 if (counts.ContainsKey(value)){
         counts[value] = counts[value] + 1;
         var b = counts[value] + value;
     var  sde = counts[value];
    // System.Console.WriteLine(sde + ":"+value);
    }
    else {
     
        counts.Add(value, 1);
        var a =counts[value] + value;
        
       
         var  id = counts[value];
        
 // System.Console.WriteLine(id+value);
    }
}

foreach(var nicat in counts ){
    System.Console.WriteLine(nicat);
}











