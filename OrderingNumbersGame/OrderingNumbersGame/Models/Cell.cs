using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingNumbersGame.Utils;

namespace OrderingNumbersGame.Models
{
    public class Cell:NotificationObject
    {
	    private int _xLocation;
	    private int _yLocation;
	    private int? _value;

	    public int XLocation
	    {
		    get => _xLocation;
		    set
		    {
			    if (value == _xLocation) return;
			    _xLocation = value;
			    RaisePropertyChanged();
		    }
	    }

	    public int YLocation
	    {
		    get => _yLocation;
		    set
		    {
			    if (value == _yLocation) return;
			    _yLocation = value;
			    RaisePropertyChanged();
		    }
	    }

	    public int? Value
	    {
		    get => _value;
		    set
		    {
			    if (value == _value) return;
			    _value = value;
			    RaisePropertyChanged();
		    }
	    }
    }
}
