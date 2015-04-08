using UnityEngine;
using System.Collections;

public class slave : MonoBehaviour {

	private short _beauty, 
				  _empathy, 
				  _fame, 
				  _intellect, 
				  _nature, 
				  _pride, 
				  _physique, 
				  _rank, 
				  _style, 
				  _temperment;

	private short _obedience, 
				  _custom, 
				  _spoil, 
				  _expression, 
				  _pet, 
				  _pony, 
				  _medical;

	private ushort _gender;

	#region core_accessors
	// The value must be a signed integer that rests between -5 and 5.
	// Anything else is to be simply ignored as a cheating attempt, 
	// and to avoid possible corruption.
	public short Beauty {
		get { return _beauty; }
		set {
			if ((value > -6) && (value < 6)) {
				_beauty = value; 
			}
		}
	}
	
	public short Empathy {
		get { return _empathy; }
		set {
			if ((value > -6) && (value < 6)) {
				_empathy = value;
			}
		}
	}
	
	// The value must be a signed integer that rests between 0 and 5.
	// Anything else is to be simply ignored as a cheating attempt, 
	// and to avoid possible corruption.
	public short Fame {
		get { return _fame; }
		set {
			if ((value >= 0) && (value < 6)) {
				_fame = value;
			}
		}
	}
	
	public short Intellect {
		get { return _intellect; }
		set {
			if ((value > -6) && (value < 6)) {
				_intellect = value;
			}
		}
	}
	
	public short Nature {
		get { return _nature; }
		set {
			if ((value > -6) && (value < 6)) {
				_nature = value;
			}
		}
	}
	
	public short Pride {
		get { return _pride; }
		set {
			if ((value > -6) && (value < 6)) {
				_pride = value;
			}
		}
	}
	
	public short Physique {
		get { return _physique; }
		set {
			if ((value > -6) && (value < 6)) {
				_physique = value;
			}
		}
	}
	
	public short Rank {
		get { return _rank; }
		set {
			if ((value > -6) && (value < 6)) {
				_rank = value;
			}
		}
	}
	
	public short Style {
		get { return _style; }
		set {
			if ((value > -6) && (value < 6)) {
				_style = value;
			}
		}
	}
	
	public short Temperment {
		get { return _temperment; }
		set {
			if ((value > -6) && (value < 6)) {
				_temperment = value;
			}
		}
	}

	public ushort Gender {
		get { return _gender;}
		set {
			_gender = value;
		}
	}
	#endregion

	public void generateNPC() {
		_gender = (ushort)Random.Range(0,2);
		_fame = 0;
		_rank = 0;
		_spoil = 0;
		//_obedience

		// Core Statistics
		// generate a random initialization from 0 through 5
		_beauty = (short)Random.Range (0, 6);
		_empathy = (short)Random.Range (0, 6);
		_intellect = (short)Random.Range (0, 6);
		_nature = (short)Random.Range (0, 6);
		_pride = (short)Random.Range (0, 6);
		_physique = (short)Random.Range (0, 6);
		_style = (short)Random.Range (0, 6);
		_temperment = (short)Random.Range (0, 6);

		_custom = (short)Random.Range (0, 6);

		// Skills
		// generate a random initialization from 0 through 2
		_expression = (short)Random.Range (0, 3);
		_pet = (short)Random.Range (0, 3);
		_pony = (short)Random.Range (0, 3);
		_medical = (short)Random.Range (0, 3);

	}
}
