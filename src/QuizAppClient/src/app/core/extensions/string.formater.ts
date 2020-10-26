interface String {
    format(...args: string[]): string;
}

String.prototype.format = function(...args: string[]): string {
    const s = this;
    // tslint:disable-next-line:only-arrow-functions
    const lol = s.replace(/{(\d+)}/g, function(match, paramNumber) {
        return (typeof args[paramNumber] !== 'undefined') ? args[paramNumber] : match;
      });
    // console.log(lol);
    // tslint:disable-next-line:only-arrow-functions
    return s.replace(/{(\d+)}/g, function(match, paramNumber) {
      return (typeof args[paramNumber] !== 'undefined') ? args[paramNumber] : match;
    });
};
