namespace FriendLetter.Models
{
  public class LetterVariable
  {
      private string _recipient;
      private string _sender;
      private string _location;
      private string _souvenirs;


      public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
        return _sender;
    }

    public void SetSender(string newSender)
    {
        _sender = newSender;
    }

    public string GetLocation()
    {
        return _location;
    }

    public void SetLocation(string newLocation)
    {
        _location = newLocation;
    }

    public string GetSouvenir()
    {
        return _souvenirs;
    }

    public void SetSouvenir(string newSouvenirs)
    {
        _souvenirs = newSouvenirs;
    }



  }
}