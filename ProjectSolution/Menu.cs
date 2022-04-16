//use singleton here

namespace ProjectSolution
{
    internal class Menu
    {
        private static Menu? MeunInstance = null; // Unique menu instance


        // Return unique instance of menu 
        private static Menu GetInstance()
        {
            if(MeunInstance == null)
            {
                MeunInstance =  new Menu();
            }
            return MeunInstance;
        }

 
    }
}
