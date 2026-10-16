    // Problems in this design:
    //   - Cunstructor Calling: If anyone need to create object from this class will input 20 parameter, this will be unreadable and there is huge probability to input wrong data or change two argument places.
    //   - Proberty Adding: if anyone add new property, all objects of this class will occur bugs, you need to add this property in each constructor calling.
    //   - Violate Single Responsibility: Violate the most important principle in solid, this class contain alot of unconnected Responsibilities, this will cause many problems like.
    /*        - Class will be huge
              -  Will Can't reuse the code without other data.
              -  Unit Test Problem: Will Can't test logic without call other data
              -  Conflicts: if you work on detected part inside this class, and other developer work on differenct part, maybe will occur an error when merging.
    */

    // We Can solve this problem by using OrderBuilder Pattern, using other class to build the constructor, passing mandatory properties and create methods that assignes other properties.