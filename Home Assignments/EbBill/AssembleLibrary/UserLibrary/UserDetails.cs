using System;


namespace UserLibrary
{
    public class UserDetails
    {
        private static int s_meterId=1000;

        public string MeterId {get;}
        public string UserName {get;set;}
        public long PhoneNumber {get;set;}
        public string MailID {get;set;}
        public int Unit {get;set;}



        public UserDetails(string name,long phoneNumber,string mailId, int unit)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=name;
            PhoneNumber=phoneNumber;
            MailID=mailId;
        }

        public double ebAmount(double unit)
        {
            double ebAmount1=0;
            if(unit<=100)
            {
                ebAmount1=0;
            }
            else if(unit>100 && unit<=200)
            {
                unit=unit-100;
                ebAmount1=unit*2.5;
            }
            else if(unit>200 && unit<=400)
            {
                ebAmount1+=(unit-200)*4;
                ebAmount1=ebAmount1+(100*2.5);
            }
            else if(unit>400 && unit<=600)
            {
                ebAmount1+=(unit-400)*6;
                ebAmount1=ebAmount1+(200*4);
                ebAmount1=ebAmount1+(100*2.5);
            }
            else if(unit>600)
            {
                ebAmount1+=(unit-600)*10;
                ebAmount1=ebAmount1+(200*6);
                ebAmount1=ebAmount1+(200*4);
                ebAmount1=ebAmount1+(100*2.5);
            }
            return ebAmount1;
        }
        
    }
}