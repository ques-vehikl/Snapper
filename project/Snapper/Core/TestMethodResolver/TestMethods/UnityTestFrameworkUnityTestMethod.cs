using System.Reflection;

namespace Snapper.Core.TestMethodResolver.TestMethods
{
    internal class UnityTestFrameworkUnityTestMethod : BaseTestMethod
    {
        public UnityTestFrameworkUnityTestMethod(MemberInfo method, string fileName)
            : base(method, fileName)
        {}

        protected override string AttributeName => "UnityTestFramework.UnityTestAttribute";
    }
}
