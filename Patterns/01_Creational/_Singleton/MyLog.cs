namespace _Singleton
{
    public class MyLog
    {
        protected MyLog()
        { }

        private static MyLog myLog;

        public static MyLog Init()
        {
            if (myLog != null)
            {
                myLog = new MyLog();
            }

            return myLog;
        }
    }
}