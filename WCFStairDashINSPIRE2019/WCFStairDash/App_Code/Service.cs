using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<ServiceTeamObj> GetAllData(int value)
    {
        //gets all objects and returns them
        //create repo and get all
        //transfer
        //return

        List<ServiceTeamObj> returnTeamList = new List<ServiceTeamObj>();

        //TEMPORARY CODE BELOW
        ServiceTeamObj teamObj1 = new ServiceTeamObj()
        {
            Name = "CRM Platform Team",
            Score = 164
        };

        ServiceTeamObj teamObj2 = new ServiceTeamObj()
        {
            Name = "Integration and DevOps Engineering",
            Score = 122
        };

        ServiceTeamObj teamObj3 = new ServiceTeamObj()
        {
            Name = "Architecture Team",
            Score = 88
        };

        ServiceTeamObj teamObj4 = new ServiceTeamObj()
        {
            Name = "Sales Team",
            Score = 65
        };


        returnTeamList.Add(teamObj1);
        returnTeamList.Add(teamObj2);
        returnTeamList.Add(teamObj3);
        returnTeamList.Add(teamObj4);

        return returnTeamList;
        //
    }

    public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}




}

public partial class ServiceTeamObj
    {
    public string Name { get; set; }
    public float Score { get; set; }

    }
