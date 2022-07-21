using System;
using System.Collections.Generic;
using UnityEngine;

public static class IoCContainer
{
    private static Dictionary<Type, object> _services = new();

    public static void Register<TImplementation>() where TImplementation : class
    {
        Register<TImplementation, TImplementation>();
    }

    public static bool IsRegistered<TInterface>()
    {
        return _services.ContainsKey(typeof(TInterface));
    }

    public static void Register<TInterface, TImplementation>() where TImplementation : class, TInterface
    {
        try
        {
            RegisterInstance<TInterface>(Activator.CreateInstance<TImplementation>());
        }
        catch (Exception e)
        {
            Debug.LogError(e);
        }
    }

    public static void RegisterInstance<TInterface>(TInterface implementation)
    {
        _services[typeof(TInterface)] = implementation;
    }

    public static T Get<T>()
    {
        if (TryGet(typeof(T), out object instance))
        {
            return (T)instance;
        }

        Debug.LogError($"IOC Container haven't registration for {typeof(T).ToString()}");
        return default;
    }

    private static bool TryGet(Type objectType, out object instance)
    {
        if (!_services.TryGetValue(objectType, out instance))
            return false;

        return true;
    }
}