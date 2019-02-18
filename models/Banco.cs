using System;
using System.Collections.Generic;

namespace bank_app.Models {

  public class Banco {

    public static List<Banco> listBanks = new List<Banco>(){
      new Banco() { Name= "BCP"},
      new Banco() { Name= "Interbank"},
      new Banco() { Name= "Scotiabank"}
    };

    public string Name { get; set; }
    
  }
} 