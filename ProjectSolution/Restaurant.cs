//State and Observer
//restaruant is the subject for table

namespace ProjectSolution
{
    internal class Restaurant
    {
        //state represents if the restaurant is open or not
        bool State { get; set; }

        public void open(Table[] tables)
        {
            State = true;
            foreach(var table in tables)
            {
                table.IsOccupied = false;
            }
        }
        //close method
    }
}

