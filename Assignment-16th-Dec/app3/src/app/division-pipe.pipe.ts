import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'divisionPipe',
})
export class DivisionPipePipe implements PipeTransform {
  transform(a: number, b: number): unknown {
    return a / b;
  }
}
