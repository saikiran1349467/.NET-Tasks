using System;

namespace DisposableExample
{
    public class Cricket : IDisposable
    {
        private bool isDisposed = false;

        // Constructor
        public Cricket()
        {
            Console.WriteLine("A new cricketer has been created.");
        }

        // Method that uses unmanaged resources
        public void Chirp()
        {
            Console.WriteLine("Chirp chirp!");
        }

        // Implementation of IDisposable.Dispose()
        public void Dispose()
        {
           // Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected method that handles the actual resource release
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // Release any managed resources here
                }

                // Release any unmanaged resources here
                Console.WriteLine("The cricketier has been disposed.");
                isDisposed = true;
            }

        }
        ~Cricket()
        {
            Dispose(false);
        }
    }



    public class Program
    {
        static void Main()
        {
        //    using (Cricket cricket = new Cricket())
        //    {
        //        cricket.Chirp();
        //    }
          Cricket myCricket = new Cricket();

        // Call the Chirp method
        myCricket.Chirp();

        // The cricket object is now eligible for garbage collection
        // The destructor will be called when the garbage collector runs
        myCricket = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

            Console.ReadLine();
        }
    }


}
