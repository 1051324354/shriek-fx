using Microsoft.Extensions.DependencyInjection;

namespace Shriek.DependencyInjection
{
    /// <summary>
    /// ѡ����
    /// </summary>
    internal interface ISelector
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        void Populate(IServiceCollection services);
    }
}