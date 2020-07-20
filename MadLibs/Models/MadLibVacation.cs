namespace MadLibs.Models
{
  public class MadLibVacation
  {
    public string Adjective { get; set; }
    public string Adjective2 { get; set; }
    public string Noun { get; set; }
    public string Noun2 {get; set;}
    public string PluralNoun {get; set;}
    public string Game {get; set;}
    public string PluralNoun2 {get; set;}
    public string IngVerb {get; set;}
    public string Noun3 {get; set;}
    public string Plant {get; set;}
    public string BodyPart {get; set;}
    public string Location {get; set;}
    public string IngVerb2 {get; set;}
    public string Adjective3 {get; set;}
    public string Number {get; set;}
    public string PluralNoun3 {get; set;}

    
    public MadLibVacation(string adjective, string adjective2, string noun, string noun2, string pluralNoun, string game, string pluralNoun2, string ingVerb, string noun3, string plant, string bodyPart, string location, string ingVerb2, string adjective3, string number, string pluralNoun3)
    {
    Adjective = adjective;
    Adjective2 = adjective2;
    Noun = noun;
    Noun2 = noun2;
    PluralNoun = pluralNoun;
    Game = game;
    PluralNoun2 = pluralNoun2;
    IngVerb = ingVerb;
    Noun3 = noun3;
    Plant = plant;
    BodyPart = bodyPart;
    Location = location;
    IngVerb2 = ingVerb2;
    Adjective3 = adjective3;
    Number = number;
    PluralNoun3 = pluralNoun3;
    }
  }
}