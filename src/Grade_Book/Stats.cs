namespace Grade_Book
{
    public class Stats
    {
        public double Average;
        public double High;
        public double Low;
        public char Letter;


        public Stats(double Ave, double high, double low, char letter){
            this.Average=Ave;
            this.High=high;
            this.Low=low;
            this.Letter=letter;
        }
   
    }
}