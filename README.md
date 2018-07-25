# ManagedInjection

A proof of concept for injecting a pre-compiled .net assembly in memory at runtime with zero pre-knowledge of its assembly namespace or type. All that is necessary is a convention for the initial method name which will be instantiated, or just have the assembly initialize via its Constructor for a true "zero knowledge" scenario.

It's as easy as `ManagedInjection.Inject(b64);` passing a base64 string of the bytes of an assembly.
