
#include "interfaces.h"
#include "iid.h"
#include <stdio.h>
#include <string>
#include <locale>
#include <codecvt>

class CoCar : public IEngine, public ICreateCar, public IStats, public IDispatch {
private:
	long m_refCount;
	BSTR	m_petName; // ������������� ����� SysAllocString(), 
					   // �������� � ����� ����� SysFreeString()
	int		m_maxSpeed; // ������������ ��������
	int		m_currSpeed; // ������� �������� ����r
	const int MAX_SPEED = 250;
	int MAX_NAME_LENGTH = 20;

	CRITICAL_SECTION g_cs;
	long g_mtaUsageCount = 0;
public:
	CoCar();
	~CoCar();

	// IUnknown
	STDMETHODIMP QueryInterface(REFIID riid, void** pIFace);
	STDMETHODIMP_(DWORD)AddRef();
	STDMETHODIMP_(DWORD)Release();

	// IEngine
	STDMETHODIMP SpeedUp();
	STDMETHODIMP GetMaxSpeed(int* maxSpeed);
	STDMETHODIMP GetCurSpeed(int* curSpeed);

	// IStats
	STDMETHODIMP DisplayStats();
	STDMETHODIMP GetPetName(BSTR* petName);

	//IDispatch
	STDMETHOD_(HRESULT __stdcall, GetTypeInfoCount)(UINT* pctinfo);
	STDMETHOD_(HRESULT __stdcall, GetTypeInfo)(UINT iTInfo, LCID lcid, ITypeInfo** ppTInfo);
	STDMETHOD_(HRESULT __stdcall, GetIDsOfNames)(REFIID riid, LPOLESTR* rgszNames, UINT cNames, LCID lcid, DISPID* rgDispId);
	STDMETHOD_(HRESULT __stdcall, Invoke)(DISPID dispIdMember, REFIID riid, LCID lcid, WORD wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, UINT* puArgErr);

	// ICreateCar
	STDMETHODIMP SetPetName(BSTR petName);
	STDMETHODIMP SetMaxSpeed(int maxSp);

};

