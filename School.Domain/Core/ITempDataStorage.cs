using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    /// <summary>
    /// Represents temporary storage
    /// </summary>
    /// <typeparam name="T">Storage record mapping class</typeparam>
    public interface ITempDataStorage<T> : IQueryable<T>, IDisposable, IAsyncDisposable where T : class
    {
    }
}
