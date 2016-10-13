namespace CfSampleAppDotNetCore.Models
{
    public class VcapServices
    {
        public MongoDB[] mongodb { get; set; }
        public class MongoDB
        {
            public Credentials credentials { get; set; }

            public class Credentials
            {
                public string uri  { get; set; }
                public string database  { get; set; }
            }
        }
    }
}
