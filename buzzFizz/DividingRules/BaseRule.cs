namespace buzzFizz.DividingRules
{
    public abstract class BaseRule
    {
        public abstract int Divider { get; }

        public abstract string WordToPrint { get; }

        public virtual string ProcessInput(int num)
        {
            // validate input
            this.IsValidNum(num);

            if (num % this.Divider == 0)
                return this.WordToPrint; // return 'buzz' or 'fizz'
            else
                return num.ToString();
        }

        private bool IsValidNum(object num)
        {
            if (num is not int)
                throw new ArgumentException("Nope! we are not dealing with integers!");

            if (num is null)
                throw new ArgumentException("Nope! You think you can fool me!");

            return true;
        }
    }
}