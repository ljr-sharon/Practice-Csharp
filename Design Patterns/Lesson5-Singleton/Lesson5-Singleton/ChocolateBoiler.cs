using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Singleton
{
    public sealed class ChocolateBoiler // 防止被繼承
    {
        private bool empty;
        private bool boiled;
        private static volatile ChocolateBoiler _instance;
        // 專門用來鎖的靜態物件
        private static readonly object _syncRoot = new object();
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new ChocolateBoiler();
                        }
                    }
                }
                return _instance;
            }
        }

        //private static readonly Lazy<ChocolateBoiler> _lazyInstance
        //    = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler(),isThreadSafe: true);
        //public static ChocolateBoiler Instance => _lazyInstance.Value;

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
            }
        }
        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
            }
        }
        public bool IsEmpty()
        {
            return empty;
        }
        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
