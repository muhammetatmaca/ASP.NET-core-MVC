namespace BtkAkademi.Models
{
    public class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;   //sınıf içindeki listeye bakarak her seferinde numarlı dönüs
        
        public static  void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }

}
