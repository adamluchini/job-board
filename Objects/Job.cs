using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class JobOpening
  {
    private string _title;
    private string _description;
    private string _contact;
    private static List<JobOpening> _instances = new List<JobOpening> {};
    public JobOpening (string title, string description, string contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetContact()
    {
      return _contact;
    }
    public void SetContact(string newContact)
    {
      _contact = newContact;
    }
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
