using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;

// ReSharper disable once CheckNamespace
namespace Blueshift.EntityFrameworkCore.Infrastructure
{
    public class MongoDbContextOptionsBuilder
    {
        public MongoDbContextOptionsBuilder([NotNull] DbContextOptionsBuilder optionsBuilder)
        {
            OptionsBuilder = Check.NotNull(optionsBuilder, nameof(optionsBuilder));
        }

        protected virtual DbContextOptionsBuilder OptionsBuilder { get; }
    }
}