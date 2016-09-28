using DavidPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidPortal.Infrastructure.Abstract
{
    public interface IMenuProvider
    {
        IEnumerable<MenuViewModel> MenuViewModels { get; }
    }
}
