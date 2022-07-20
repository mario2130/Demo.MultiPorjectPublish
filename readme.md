## Publish proyectos especificos

Cuando deseamos publicar uno o varios proyectos contenidos dentro de una solución

La mejor opción que tenemos para publicar es realizando el publish sobre la solución

`````
dotnet publish
`````

el problema es que al publicar la solución, todos los proyectos asociados a la solución serán publicados

para discriminar los proyectos que no requieren ser publicados, es necesario agregar el siguiente tag dentro del proyecto (archivo csproj)

````
<PropertyGroup>
        ...
        <IsPublishable>false</IsPublishable>
 </PropertyGroup>
````

ya con esto es factible publicar proyectos especificos (indicandole a la solución los que no queremos que compile). La publicación será dentro de la misma carpeta bin del proyecto

Para crear una ruta especifica de publicación, debemos crear un perfil de publicación

luego de ser creado, podemos ejecutar ese plan de ejecución para toda la solución y serán depositados en la ruta especificada

````
dotnet publish -p:PublishProfile=LocalProfile
````


link de referencia: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish
