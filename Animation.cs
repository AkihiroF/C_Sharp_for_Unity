using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
	private bool _isOpened;
	[SerializeField] private Animator _animator1;
	[SerializeField] private Animator _animator2;
	[SerializeField] private Animator _animator3;


	public void Open()
	{
		_animator1.SetBool("isOpened", _isOpened);
		_animator2.SetBool("isOpened", _isOpened);
		_animator3.SetBool("isOpened", _isOpened);
		_isOpened = !_isOpened;
	}
}
