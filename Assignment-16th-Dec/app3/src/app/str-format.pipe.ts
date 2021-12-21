import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'strFormat'
})
export class StrFormatPipe implements PipeTransform {

  transform(s: string, op: string): unknown {
    return s.replace(" ", op);
  }

}
