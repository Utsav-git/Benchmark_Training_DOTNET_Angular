import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'countWords'
})
export class CountWordsPipe implements PipeTransform {

  transform(s:string): unknown {
    return s.length;
  }

}
