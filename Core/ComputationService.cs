using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ComputationService : IComputationService
    {
        public List<ComputationResult> Compute(Settings settings)
        {
            List<ComputationResult> computationResultList = new List<ComputationResult>();

            List<char> charList = Settings.GetChars(settings);

            for (int i = settings.MinPasswordLength; i <= settings.MaxPasswordLength; i++)
            {
                UInt64 tryCount = 1;
                for (int j = 1; j <= i; j++)
                {
                    int n = charList.Count;
                    var list = settings.ExactCharList.Where(ec => ec.Index == j).FirstOrDefault();
                    if (list != null && list.Chars.Any())
                    {
                        n = list.Chars.Length;
                    }

                    //tryCount *= Combination(n, 1);
                    tryCount *= (ulong)n;
                }

                computationResultList.Add(new ComputationResult(i, tryCount));
            }

            return computationResultList;
        }

        private long Combination(int n, int r)
        {
            return Permutation(n) / (Permutation(r) * Permutation(n - r));
        }

        private long Permutation(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}