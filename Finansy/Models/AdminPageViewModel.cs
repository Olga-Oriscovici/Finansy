using System.Collections.Generic;

namespace Finansy.Models
{
    public class AdminPageViewModel
    {

        public IEnumerable<WalletInfo> ?Wallets { get; set; }
        public IEnumerable<Wastes> ?Wastes { get; set; }
    }
}
