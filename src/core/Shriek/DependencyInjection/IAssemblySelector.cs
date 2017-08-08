using System;
using System.Collections.Generic;
using System.Reflection;

namespace Shriek.DependencyInjection
{
    /// <summary>
    /// ����ѡ����
    /// </summary>
    public interface IAssemblySelector : IFluentInterface
    {
        /// <summary>
        /// �������� <typeparamref name="T"/> ���ڳ���ɨ������.
        /// </summary>
        /// <typeparam name="T">��Ҫɨ��ĳ����е�һ�����͡�</typeparam>
        IImplementationTypeSelector FromAssemblyOf<T>();

        /// <summary>
        /// ��ɨ����� <paramref name="types"/> ���ÿ�� <see cref="Type"/> �������ڵĳ����е����͡�
        /// </summary>
        /// <param name="types">�������飬��ɨ���������ڵĳ��򼯡�</param>
        /// <exception cref="ArgumentNullException">������ <paramref name="types"/> ��ֵΪ <c>null</c>.</exception>
        IImplementationTypeSelector FromAssembliesOf(params Type[] types);

        /// <summary>
        /// ��ɨ����� <paramref name="types"/> ���ÿ��<see cref="Type"/> �������ڵĳ����е����͡�
        /// </summary>
        /// <param name="types">�����б���ɨ���������ڵĳ��򼯡�</param>
        /// <exception cref="ArgumentNullException">������ <paramref name="types"/> ��ֵΪ <c>null</c>.</exception>
        IImplementationTypeSelector FromAssembliesOf(IEnumerable<Type> types);

        /// <summary>
        /// ���� <paramref name="assemblies"/> �е�ÿ�� <see cref="Assembly"/> ��ɨ�����͡�
        /// </summary>
        /// <param name="assemblies">��Ҫɨ��ĳ���</param>
        /// <exception cref="ArgumentNullException">������ <paramref name="assemblies"/> ��ֵΪ <c>null</c>.</exception>
        IImplementationTypeSelector FromAssemblies(params Assembly[] assemblies);

        /// <summary>
        /// ���� <paramref name="assemblies"/> �е�ÿ�� <see cref="Assembly"/> ��ɨ�����͡�
        /// </summary>
        /// <param name="assemblies">��Ҫɨ��ĳ���</param>
        /// <exception cref="ArgumentNullException">������ <paramref name="assemblies"/> ��ֵΪ <c>null</c>.</exception>
        IImplementationTypeSelector FromAssemblies(IEnumerable<Assembly> assemblies);
    }
}