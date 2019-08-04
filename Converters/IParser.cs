using System.Collections.Generic;

namespace RestApiDOTNETCore.Converters{
  public interface IParser<O,D>{
    
    D Parse(O origin);
    List<D> ParseList(List<O> origin);
  }
}