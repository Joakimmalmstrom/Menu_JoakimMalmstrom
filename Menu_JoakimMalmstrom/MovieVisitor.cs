namespace Menu_JoakimMalmstrom
{
    internal class MovieVisitor
    {
        // Prop Age that goes in the constructor
        public int Age { get; set; }
        
        // Rules for the movie's price classes
        public MoviePriceClass priceClass
        {
            get
            {
                if (Age < 20)
                {
                    return MoviePriceClass.teen;
                }
                else if (Age > 64)
                {
                    return MoviePriceClass.pension;
                }
                else
                {
                    return MoviePriceClass.standard;
                }
            }
        }

        public MovieVisitor(int age)
        {
            Age = age;
        }
    }
}