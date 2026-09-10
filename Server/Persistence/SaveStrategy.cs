using System;

namespace Server
{
    public abstract class SaveStrategy
    {
        public abstract string Name { get; }

        public static SaveStrategy Acquire()
        {
            // Force the server to use the safe, single-threaded save method
            // This prevents the 'Hashtable insert failed' crash during saves.
            return new StandardSaveStrategy();
        }

        public abstract void Save(SaveMetrics metrics, bool permitBackgroundWrite);

        public abstract void ProcessDecay();
    }
}