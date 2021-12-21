import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'repeatWord'
})
export class RepeatWordPipe implements PipeTransform {

  transform(s: string, n: number): unknown {
    return s.repeat(n);
  }

}
