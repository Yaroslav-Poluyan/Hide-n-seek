using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace _CodeBase.StaticData.StaticData
{
    public interface IStaticDataService 
    {
        Task Load(CancellationToken cancellationToken);
        T GetStaticData<T>() where T : IStaticData;
        Task LoadStaticData<T>() where T : ScriptableObject, IStaticData;
    }
}