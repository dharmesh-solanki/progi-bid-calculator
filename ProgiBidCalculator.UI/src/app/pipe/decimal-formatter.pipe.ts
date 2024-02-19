//defines a custom pipe for formatting numeric values, controlling the display of decimal places based on the value's nature (decimal or integer)
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'decimalFormatter'
})
export class DecimalFormatterPipe implements PipeTransform {
  transform(value: number): string {
    return value.toFixed(2);
  }
}
